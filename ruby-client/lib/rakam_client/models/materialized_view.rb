module RakamClient
  # 
  class MaterializedView < BaseObject
    attr_accessor :project, :name, :table_name, :query, :update_interval, :options
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'project' => :'project',
        
        # 
        :'name' => :'name',
        
        # 
        :'table_name' => :'table_name',
        
        # 
        :'query' => :'query',
        
        # 
        :'update_interval' => :'update_interval',
        
        # 
        :'options' => :'options'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'project' => :'String',
        :'name' => :'String',
        :'table_name' => :'String',
        :'query' => :'String',
        :'update_interval' => :'String',
        :'options' => :'Hash<String, Object>'
        
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
      
      if attributes[:'table_name']
        self.table_name = attributes[:'table_name']
      end
      
      if attributes[:'query']
        self.query = attributes[:'query']
      end
      
      if attributes[:'update_interval']
        self.update_interval = attributes[:'update_interval']
      end
      
      if attributes[:'options']
        if (value = attributes[:'options']).is_a?(Array)
          self.options = value
        end
      end
      
    end

  end
end
