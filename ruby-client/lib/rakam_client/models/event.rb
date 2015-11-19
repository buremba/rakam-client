module RakamClient
  # 
  class Event < BaseObject
    attr_accessor :project, :collection, :context, :properties
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'project' => :'project',
        
        # 
        :'collection' => :'collection',
        
        # 
        :'context' => :'context',
        
        # 
        :'properties' => :'properties'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'project' => :'String',
        :'collection' => :'String',
        :'context' => :'EventContext',
        :'properties' => :'Object'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'project']
        self.project = attributes[:'project']
      end
      
      if attributes[:'collection']
        self.collection = attributes[:'collection']
      end
      
      if attributes[:'context']
        self.context = attributes[:'context']
      end
      
      if attributes[:'properties']
        self.properties = attributes[:'properties']
      end
      
    end

  end
end
