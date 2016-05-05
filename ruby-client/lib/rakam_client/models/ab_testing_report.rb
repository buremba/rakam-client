require 'date'

module RakamClient
  class ABTestingReport
    attr_accessor :project

    attr_accessor :name

    attr_accessor :variants

    attr_accessor :goal

    attr_accessor :options

    attr_accessor :id

    attr_accessor :collection_name

    attr_accessor :connector_field

    # Attribute mapping from ruby-style variable name to JSON key.
    def self.attribute_map
      {
        
        :'project' => :'project',
        
        :'name' => :'name',
        
        :'variants' => :'variants',
        
        :'goal' => :'goal',
        
        :'options' => :'options',
        
        :'id' => :'id',
        
        :'collection_name' => :'collectionName',
        
        :'connector_field' => :'connectorField'
        
      }
    end

    # Attribute type mapping.
    def self.swagger_types
      {
        :'project' => :'String',
        :'name' => :'String',
        :'variants' => :'Array<Variant>',
        :'goal' => :'Goal',
        :'options' => :'Object',
        :'id' => :'Integer',
        :'collection_name' => :'String',
        :'connector_field' => :'String'
        
      }
    end

    def initialize(attributes = {})
      return unless attributes.is_a?(Hash)

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'project']
        self.project = attributes[:'project']
      end
      
      if attributes[:'name']
        self.name = attributes[:'name']
      end
      
      if attributes[:'variants']
        if (value = attributes[:'variants']).is_a?(Array)
          self.variants = value
        end
      end
      
      if attributes[:'goal']
        self.goal = attributes[:'goal']
      end
      
      if attributes[:'options']
        self.options = attributes[:'options']
      end
      
      if attributes[:'id']
        self.id = attributes[:'id']
      end
      
      if attributes[:'collectionName']
        self.collection_name = attributes[:'collectionName']
      end
      
      if attributes[:'connectorField']
        self.connector_field = attributes[:'connectorField']
      end
      
    end

    # Check equality by comparing each attribute.
    def ==(o)
      return true if self.equal?(o)
      self.class == o.class &&
          project == o.project &&
          name == o.name &&
          variants == o.variants &&
          goal == o.goal &&
          options == o.options &&
          id == o.id &&
          collection_name == o.collection_name &&
          connector_field == o.connector_field
    end

    # @see the `==` method
    def eql?(o)
      self == o
    end

    # Calculate hash code according to all attributes.
    def hash
      [project, name, variants, goal, options, id, collection_name, connector_field].hash
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
