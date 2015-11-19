module RakamClient
  # 
  class RetentionAction < BaseObject
    attr_accessor :collection
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'collection' => :'collection'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'collection' => :'String'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'collection']
        self.collection = attributes[:'collection']
      end
      
    end

  end
end
