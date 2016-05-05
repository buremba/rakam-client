require 'date'

module RakamClient
  class AnalyzeRequest
    attr_accessor :project

    attr_accessor :measure

    attr_accessor :grouping

    attr_accessor :segment

    attr_accessor :filter_expression

    attr_accessor :start_date

    attr_accessor :end_date

    attr_accessor :collections

    # Attribute mapping from ruby-style variable name to JSON key.
    def self.attribute_map
      {
        
        :'project' => :'project',
        
        :'measure' => :'measure',
        
        :'grouping' => :'grouping',
        
        :'segment' => :'segment',
        
        :'filter_expression' => :'filterExpression',
        
        :'start_date' => :'startDate',
        
        :'end_date' => :'endDate',
        
        :'collections' => :'collections'
        
      }
    end

    # Attribute type mapping.
    def self.swagger_types
      {
        :'project' => :'String',
        :'measure' => :'Measure',
        :'grouping' => :'Reference',
        :'segment' => :'Reference',
        :'filter_expression' => :'String',
        :'start_date' => :'Date',
        :'end_date' => :'Date',
        :'collections' => :'Array<String>'
        
      }
    end

    def initialize(attributes = {})
      return unless attributes.is_a?(Hash)

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'project']
        self.project = attributes[:'project']
      end
      
      if attributes[:'measure']
        self.measure = attributes[:'measure']
      end
      
      if attributes[:'grouping']
        self.grouping = attributes[:'grouping']
      end
      
      if attributes[:'segment']
        self.segment = attributes[:'segment']
      end
      
      if attributes[:'filterExpression']
        self.filter_expression = attributes[:'filterExpression']
      end
      
      if attributes[:'startDate']
        self.start_date = attributes[:'startDate']
      end
      
      if attributes[:'endDate']
        self.end_date = attributes[:'endDate']
      end
      
      if attributes[:'collections']
        if (value = attributes[:'collections']).is_a?(Array)
          self.collections = value
        end
      end
      
    end

    # Check equality by comparing each attribute.
    def ==(o)
      return true if self.equal?(o)
      self.class == o.class &&
          project == o.project &&
          measure == o.measure &&
          grouping == o.grouping &&
          segment == o.segment &&
          filter_expression == o.filter_expression &&
          start_date == o.start_date &&
          end_date == o.end_date &&
          collections == o.collections
    end

    # @see the `==` method
    def eql?(o)
      self == o
    end

    # Calculate hash code according to all attributes.
    def hash
      [project, measure, grouping, segment, filter_expression, start_date, end_date, collections].hash
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
