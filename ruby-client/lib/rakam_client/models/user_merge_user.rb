require 'date'

module RakamClient
  class UserMergeUser
    attr_accessor :project

    attr_accessor :user

    attr_accessor :api

    attr_accessor :anonymous_id

    attr_accessor :created_at

    attr_accessor :merged_at

    # Attribute mapping from ruby-style variable name to JSON key.
    def self.attribute_map
      {
        
        :'project' => :'project',
        
        :'user' => :'user',
        
        :'api' => :'api',
        
        :'anonymous_id' => :'anonymous_id',
        
        :'created_at' => :'created_at',
        
        :'merged_at' => :'merged_at'
        
      }
    end

    # Attribute type mapping.
    def self.swagger_types
      {
        :'project' => :'String',
        :'user' => :'String',
        :'api' => :'UserContext',
        :'anonymous_id' => :'String',
        :'created_at' => :'DateTime',
        :'merged_at' => :'DateTime'
        
      }
    end

    def initialize(attributes = {})
      return unless attributes.is_a?(Hash)

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'project']
        self.project = attributes[:'project']
      end
      
      if attributes[:'user']
        self.user = attributes[:'user']
      end
      
      if attributes[:'api']
        self.api = attributes[:'api']
      end
      
      if attributes[:'anonymous_id']
        self.anonymous_id = attributes[:'anonymous_id']
      end
      
      if attributes[:'created_at']
        self.created_at = attributes[:'created_at']
      end
      
      if attributes[:'merged_at']
        self.merged_at = attributes[:'merged_at']
      end
      
    end

    # Check equality by comparing each attribute.
    def ==(o)
      return true if self.equal?(o)
      self.class == o.class &&
          project == o.project &&
          user == o.user &&
          api == o.api &&
          anonymous_id == o.anonymous_id &&
          created_at == o.created_at &&
          merged_at == o.merged_at
    end

    # @see the `==` method
    def eql?(o)
      self == o
    end

    # Calculate hash code according to all attributes.
    def hash
      [project, user, api, anonymous_id, created_at, merged_at].hash
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
