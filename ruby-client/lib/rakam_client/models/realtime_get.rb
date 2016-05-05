require 'date'

module RakamClient
  class RealtimeGet
    attr_accessor :project

    attr_accessor :table_name

    attr_accessor :filter

    attr_accessor :measure

    attr_accessor :dimensions

    attr_accessor :aggregate

    attr_accessor :date_start

    attr_accessor :date_end

    # Attribute mapping from ruby-style variable name to JSON key.
    def self.attribute_map
      {
        
        :'project' => :'project',
        
        :'table_name' => :'table_name',
        
        :'filter' => :'filter',
        
        :'measure' => :'measure',
        
        :'dimensions' => :'dimensions',
        
        :'aggregate' => :'aggregate',
        
        :'date_start' => :'date_start',
        
        :'date_end' => :'date_end'
        
      }
    end

    # Attribute type mapping.
    def self.swagger_types
      {
        :'project' => :'String',
        :'table_name' => :'String',
        :'filter' => :'String',
        :'measure' => :'Measure',
        :'dimensions' => :'Array<String>',
        :'aggregate' => :'BOOLEAN',
        :'date_start' => :'DateTime',
        :'date_end' => :'DateTime'
        
      }
    end

    def initialize(attributes = {})
      return unless attributes.is_a?(Hash)

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'project']
        self.project = attributes[:'project']
      end
      
      if attributes[:'table_name']
        self.table_name = attributes[:'table_name']
      end
      
      if attributes[:'filter']
        self.filter = attributes[:'filter']
      end
      
      if attributes[:'measure']
        self.measure = attributes[:'measure']
      end
      
      if attributes[:'dimensions']
        if (value = attributes[:'dimensions']).is_a?(Array)
          self.dimensions = value
        end
      end
      
      if attributes[:'aggregate']
        self.aggregate = attributes[:'aggregate']
      end
      
      if attributes[:'date_start']
        self.date_start = attributes[:'date_start']
      end
      
      if attributes[:'date_end']
        self.date_end = attributes[:'date_end']
      end
      
    end

    # Check equality by comparing each attribute.
    def ==(o)
      return true if self.equal?(o)
      self.class == o.class &&
          project == o.project &&
          table_name == o.table_name &&
          filter == o.filter &&
          measure == o.measure &&
          dimensions == o.dimensions &&
          aggregate == o.aggregate &&
          date_start == o.date_start &&
          date_end == o.date_end
    end

    # @see the `==` method
    def eql?(o)
      self == o
    end

    # Calculate hash code according to all attributes.
    def hash
      [project, table_name, filter, measure, dimensions, aggregate, date_start, date_end].hash
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
