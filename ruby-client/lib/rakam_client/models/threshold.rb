module RakamClient
  # 
  class Threshold < BaseObject
    attr_accessor :aggregation, :field_name, :value
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'aggregation' => :'aggregation',
        
        # 
        :'field_name' => :'fieldName',
        
        # 
        :'value' => :'value'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'aggregation' => :'String',
        :'field_name' => :'String',
        :'value' => :'Integer'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'aggregation']
        self.aggregation = attributes[:'aggregation']
      end
      
      if attributes[:'fieldName']
        self.field_name = attributes[:'fieldName']
      end
      
      if attributes[:'value']
        self.value = attributes[:'value']
      end
      
    end

    def aggregation=(aggregation)
      allowed_values = ["count", "sum"]
      if aggregation && !allowed_values.include?(aggregation)
        fail "invalid value for 'aggregation', must be one of #{allowed_values}"
      end
      @aggregation = aggregation
    end

  end
end
