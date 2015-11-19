module RakamClient
  # 
  class FunnelStep < BaseObject
    attr_accessor :collection, :filter_expression
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'collection' => :'collection',
        
        # 
        :'filter_expression' => :'filterExpression'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'collection' => :'String',
        :'filter_expression' => :'String'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'collection']
        self.collection = attributes[:'collection']
      end
      
      if attributes[:'filterExpression']
        self.filter_expression = attributes[:'filterExpression']
      end
      
    end

  end
end
