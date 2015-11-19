module RakamClient
  # 
  class ScenarioStep < BaseObject
    attr_accessor :collection, :filter, :threshold
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'collection' => :'collection',
        
        # 
        :'filter' => :'filter',
        
        # 
        :'threshold' => :'threshold'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'collection' => :'String',
        :'filter' => :'String',
        :'threshold' => :'Threshold'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'collection']
        self.collection = attributes[:'collection']
      end
      
      if attributes[:'filter']
        self.filter = attributes[:'filter']
      end
      
      if attributes[:'threshold']
        self.threshold = attributes[:'threshold']
      end
      
    end

  end
end
