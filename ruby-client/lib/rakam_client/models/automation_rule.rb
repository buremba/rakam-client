module RakamClient
  # 
  class AutomationRule < BaseObject
    attr_accessor :project, :is_active, :scenarios, :actions, :custom_data, :id
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'project' => :'project',
        
        # 
        :'is_active' => :'is_active',
        
        # 
        :'scenarios' => :'scenarios',
        
        # 
        :'actions' => :'actions',
        
        # 
        :'custom_data' => :'custom_data',
        
        # 
        :'id' => :'id'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'project' => :'String',
        :'is_active' => :'BOOLEAN',
        :'scenarios' => :'Array<ScenarioStep>',
        :'actions' => :'Array<SerializableAction>',
        :'custom_data' => :'String',
        :'id' => :'Integer'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'project']
        self.project = attributes[:'project']
      end
      
      if attributes[:'is_active']
        self.is_active = attributes[:'is_active']
      end
      
      if attributes[:'scenarios']
        if (value = attributes[:'scenarios']).is_a?(Array)
          self.scenarios = value
        end
      end
      
      if attributes[:'actions']
        if (value = attributes[:'actions']).is_a?(Array)
          self.actions = value
        end
      end
      
      if attributes[:'custom_data']
        self.custom_data = attributes[:'custom_data']
      end
      
      if attributes[:'id']
        self.id = attributes[:'id']
      end
      
    end

  end
end
