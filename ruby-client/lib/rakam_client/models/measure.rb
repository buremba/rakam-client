module RakamClient
  # 
  class Measure < BaseObject
    attr_accessor :column, :aggregation
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'column' => :'column',
        
        # 
        :'aggregation' => :'aggregation'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'column' => :'String',
        :'aggregation' => :'String'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'column']
        self.column = attributes[:'column']
      end
      
      if attributes[:'aggregation']
        self.aggregation = attributes[:'aggregation']
      end
      
    end

    def aggregation=(aggregation)
      allowed_values = ["COUNT", "COUNT_UNIQUE", "SUM", "MINIMUM", "MAXIMUM", "APPROXIMATE_UNIQUE", "VARIANCE", "POPULATION_VARIANCE", "STANDARD_DEVIATION", "AVERAGE"]
      if aggregation && !allowed_values.include?(aggregation)
        fail "invalid value for 'aggregation', must be one of #{allowed_values}"
      end
      @aggregation = aggregation
    end

  end
end
