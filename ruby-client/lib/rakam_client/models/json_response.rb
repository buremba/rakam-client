module RakamClient
  # 
  class JsonResponse < BaseObject
    attr_accessor :success, :message
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'success' => :'success',
        
        # 
        :'message' => :'message'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'success' => :'BOOLEAN',
        :'message' => :'String'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'success']
        self.success = attributes[:'success']
      end
      
      if attributes[:'message']
        self.message = attributes[:'message']
      end
      
    end

  end
end
