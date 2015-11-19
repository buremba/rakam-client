module RakamClient
  # 
  class CollectionEvent < BaseObject
    attr_accessor :collection, :properties
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'collection' => :'collection',
        
        # 
        :'properties' => :'properties'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'collection' => :'String',
        :'properties' => :'Hash<String, Object>'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'collection']
        self.collection = attributes[:'collection']
      end
      
      if attributes[:'properties']
        if (value = attributes[:'properties']).is_a?(Array)
          self.properties = value
        end
      end
      
    end

  end
end
