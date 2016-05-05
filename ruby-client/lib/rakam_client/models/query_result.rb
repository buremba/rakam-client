require 'date'

module RakamClient
  class QueryResult
    attr_accessor :metadata

    attr_accessor :result

    attr_accessor :error

    attr_accessor :properties

    attr_accessor :failed

    # Attribute mapping from ruby-style variable name to JSON key.
    def self.attribute_map
      {
        
        :'metadata' => :'metadata',
        
        :'result' => :'result',
        
        :'error' => :'error',
        
        :'properties' => :'properties',
        
        :'failed' => :'failed'
        
      }
    end

    # Attribute type mapping.
    def self.swagger_types
      {
        :'metadata' => :'Array<SchemaField>',
        :'result' => :'Array<Array<Object>>',
        :'error' => :'QueryError',
        :'properties' => :'Hash<String, inline_response_200>',
        :'failed' => :'BOOLEAN'
        
      }
    end

    def initialize(attributes = {})
      return unless attributes.is_a?(Hash)

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'metadata']
        if (value = attributes[:'metadata']).is_a?(Array)
          self.metadata = value
        end
      end
      
      if attributes[:'result']
        if (value = attributes[:'result']).is_a?(Array)
          self.result = value
        end
      end
      
      if attributes[:'error']
        self.error = attributes[:'error']
      end
      
      if attributes[:'properties']
        if (value = attributes[:'properties']).is_a?(Array)
          self.properties = value
        end
      end
      
      if attributes[:'failed']
        self.failed = attributes[:'failed']
      else
        self.failed = false
      end
      
    end

    # Check equality by comparing each attribute.
    def ==(o)
      return true if self.equal?(o)
      self.class == o.class &&
          metadata == o.metadata &&
          result == o.result &&
          error == o.error &&
          properties == o.properties &&
          failed == o.failed
    end

    # @see the `==` method
    def eql?(o)
      self == o
    end

    # Calculate hash code according to all attributes.
    def hash
      [metadata, result, error, properties, failed].hash
    end

    # build the object from hash
    def build_from_hash(attributes)
      return nil unless attributes.is_a?(Hash)
      self.class.swagger_types.each_pair do |key, type|
        if type =~ /^Array<(.*)>/i
          if attributes[self.class.attribute_map[key]].is_a?(Array)
            self.send("#{key}=", attributes[self.class.attribute_map[key]].map{ |v| _deserialize($1, v) } )
          else
            #TODO show warning in debug mode
          end
        elsif !attributes[self.class.attribute_map[key]].nil?
          self.send("#{key}=", _deserialize(type, attributes[self.class.attribute_map[key]]))
        else
          # data not found in attributes(hash), not an issue as the data can be optional
        end
      end

      self
    end

    def _deserialize(type, value)
      case type.to_sym
      when :DateTime
        DateTime.parse(value)
      when :Date
        Date.parse(value)
      when :String
        value.to_s
      when :Integer
        value.to_i
      when :Float
        value.to_f
      when :BOOLEAN
        if value =~ /^(true|t|yes|y|1)$/i
          true
        else
          false
        end
      when /\AArray<(?<inner_type>.+)>\z/
        inner_type = Regexp.last_match[:inner_type]
        value.map { |v| _deserialize(inner_type, v) }
      when /\AHash<(?<k_type>.+), (?<v_type>.+)>\z/
        k_type = Regexp.last_match[:k_type]
        v_type = Regexp.last_match[:v_type]
        {}.tap do |hash|
          value.each do |k, v|
            hash[_deserialize(k_type, k)] = _deserialize(v_type, v)
          end
        end
      else # model
        _model = RakamClient.const_get(type).new
        _model.build_from_hash(value)
      end
    end

    def to_s
      to_hash.to_s
    end

    # to_body is an alias to to_body (backward compatibility))
    def to_body
      to_hash
    end

    # return the object in the form of hash
    def to_hash
      hash = {}
      self.class.attribute_map.each_pair do |attr, param|
        value = self.send(attr)
        next if value.nil?
        hash[param] = _to_hash(value)
      end
      hash
    end

    # Method to output non-array value in the form of hash
    # For object, use to_hash. Otherwise, just return the value
    def _to_hash(value)
      if value.is_a?(Array)
        value.compact.map{ |v| _to_hash(v) }
      elsif value.is_a?(Hash)
        {}.tap do |hash|
          value.each { |k, v| hash[k] = _to_hash(v) }
        end
      elsif value.respond_to? :to_hash
        value.to_hash
      else
        value
      end
    end

  end
end
