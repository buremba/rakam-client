require 'date'

module RakamClient
  class AutomationRule
    attr_accessor :project

    attr_accessor :is_active

    attr_accessor :scenarios

    attr_accessor :actions

    attr_accessor :custom_data

    attr_accessor :id

    # Attribute mapping from ruby-style variable name to JSON key.
    def self.attribute_map
      {
        
        :'project' => :'project',
        
        :'is_active' => :'is_active',
        
        :'scenarios' => :'scenarios',
        
        :'actions' => :'actions',
        
        :'custom_data' => :'custom_data',
        
        :'id' => :'id'
        
      }
    end

    # Attribute type mapping.
    def self.swagger_types
      {
        :'project' => :'String',
        :'is_active' => :'BOOLEAN',
        :'scenarios' => :'Array<ScenarioStep>',
        :'actions' => :'Array<SerializableAction>',
        :'custom_data' => :'String',
        :'id' => :'Integer'
        
      }
    end

    def initialize(attributes = {})
      return unless attributes.is_a?(Hash)

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'project']
        self.project = attributes[:'project']
      end
      
      if attributes[:'is_active']
        self.is_active = attributes[:'is_active']
      else
        self.is_active = false
      end
      
      if attributes[:'scenarios']
        if (value = attributes[:'scenarios']).is_a?(Array)
          self.scenarios = value
        end
      end
      
      if attributes[:'actions']
        if (value = attributes[:'actions']).is_a?(Array)
          self.actions = value
        end
      end
      
      if attributes[:'custom_data']
        self.custom_data = attributes[:'custom_data']
      end
      
      if attributes[:'id']
        self.id = attributes[:'id']
      end
      
    end

    # Check equality by comparing each attribute.
    def ==(o)
      return true if self.equal?(o)
      self.class == o.class &&
          project == o.project &&
          is_active == o.is_active &&
          scenarios == o.scenarios &&
          actions == o.actions &&
          custom_data == o.custom_data &&
          id == o.id
    end

    # @see the `==` method
    def eql?(o)
      self == o
    end

    # Calculate hash code according to all attributes.
    def hash
      [project, is_active, scenarios, actions, custom_data, id].hash
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
