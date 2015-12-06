module RakamClient
  # 
  class ABTestingReport < BaseObject
    attr_accessor :project, :name, :variants, :goal, :options, :id, :collection_name, :connector_field
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'project' => :'project',
        
        # 
        :'name' => :'name',
        
        # 
        :'variants' => :'variants',
        
        # 
        :'goal' => :'goal',
        
        # 
        :'options' => :'options',
        
        # 
        :'id' => :'id',
        
        # 
        :'collection_name' => :'collectionName',
        
        # 
        :'connector_field' => :'connectorField'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'project' => :'String',
        :'name' => :'String',
        :'variants' => :'Array<Variant>',
        :'goal' => :'Goal',
        :'options' => :'Object',
        :'id' => :'Integer',
        :'collection_name' => :'String',
        :'connector_field' => :'String'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'project']
        self.project = attributes[:'project']
      end
      
      if attributes[:'name']
        self.name = attributes[:'name']
      end
      
      if attributes[:'variants']
        if (value = attributes[:'variants']).is_a?(Array)
          self.variants = value
        end
      end
      
      if attributes[:'goal']
        self.goal = attributes[:'goal']
      end
      
      if attributes[:'options']
        self.options = attributes[:'options']
      end
      
      if attributes[:'id']
        self.id = attributes[:'id']
      end
      
      if attributes[:'collectionName']
        self.collection_name = attributes[:'collectionName']
      end
      
      if attributes[:'connectorField']
        self.connector_field = attributes[:'connectorField']
      end
      
    end

  end
end
