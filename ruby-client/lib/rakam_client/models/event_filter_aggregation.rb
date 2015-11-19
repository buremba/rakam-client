module RakamClient
  # 
  class EventFilterAggregation < BaseObject
    attr_accessor :field, :minimum, :maximum, :type
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'field' => :'field',
        
        # 
        :'minimum' => :'minimum',
        
        # 
        :'maximum' => :'maximum',
        
        # 
        :'type' => :'type'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'field' => :'String',
        :'minimum' => :'Integer',
        :'maximum' => :'Integer',
        :'type' => :'String'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'field']
        self.field = attributes[:'field']
      end
      
      if attributes[:'minimum']
        self.minimum = attributes[:'minimum']
      end
      
      if attributes[:'maximum']
        self.maximum = attributes[:'maximum']
      end
      
      if attributes[:'type']
        self.type = attributes[:'type']
      end
      
    end

    def type=(type)
      allowed_values = ["COUNT", "COUNT_UNIQUE", "SUM", "MINIMUM", "MAXIMUM", "APPROXIMATE_UNIQUE", "VARIANCE", "POPULATION_VARIANCE", "STANDARD_DEVIATION", "AVERAGE"]
      if type && !allowed_values.include?(type)
        fail "invalid value for 'type', must be one of #{allowed_values}"
      end
      @type = type
    end

  end
end
