module RakamClient
  # 
  class Sorting < BaseObject
    attr_accessor :column, :order
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'column' => :'column',
        
        # 
        :'order' => :'order'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'column' => :'String',
        :'order' => :'String'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'column']
        self.column = attributes[:'column']
      end
      
      if attributes[:'order']
        self.order = attributes[:'order']
      end
      
    end

    def order=(order)
      allowed_values = ["asc", "desc"]
      if order && !allowed_values.include?(order)
        fail "invalid value for 'order', must be one of #{allowed_values}"
      end
      @order = order
    end

  end
end
