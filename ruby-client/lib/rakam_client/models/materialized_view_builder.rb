module RakamClient
  # 
  class MaterializedViewBuilder < BaseObject
    attr_accessor :name, :table_name, :query, :options, :update_interval
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'name' => :'name',
        
        # 
        :'table_name' => :'table_name',
        
        # 
        :'query' => :'query',
        
        # 
        :'options' => :'options',
        
        # 
        :'update_interval' => :'updateInterval'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'name' => :'String',
        :'table_name' => :'String',
        :'query' => :'String',
        :'options' => :'Hash<String, Object>',
        :'update_interval' => :'String'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'name']
        self.name = attributes[:'name']
      end
      
      if attributes[:'table_name']
        self.table_name = attributes[:'table_name']
      end
      
      if attributes[:'query']
        self.query = attributes[:'query']
      end
      
      if attributes[:'options']
        if (value = attributes[:'options']).is_a?(Array)
          self.options = value
        end
      end
      
      if attributes[:'updateInterval']
        self.update_interval = attributes[:'updateInterval']
      end
      
    end

  end
end
