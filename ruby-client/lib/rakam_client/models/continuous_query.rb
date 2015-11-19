module RakamClient
  # 
  class ContinuousQuery < BaseObject
    attr_accessor :project, :name, :collections, :options, :table_name, :partition_keys, :raw_query
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'project' => :'project',
        
        # 
        :'name' => :'name',
        
        # 
        :'collections' => :'collections',
        
        # 
        :'options' => :'options',
        
        # 
        :'table_name' => :'tableName',
        
        # 
        :'partition_keys' => :'partitionKeys',
        
        # 
        :'raw_query' => :'rawQuery'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'project' => :'String',
        :'name' => :'String',
        :'collections' => :'Array<String>',
        :'options' => :'Hash<String, Object>',
        :'table_name' => :'String',
        :'partition_keys' => :'Array<String>',
        :'raw_query' => :'String'
        
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
      
      if attributes[:'collections']
        if (value = attributes[:'collections']).is_a?(Array)
          self.collections = value
        end
      end
      
      if attributes[:'options']
        if (value = attributes[:'options']).is_a?(Array)
          self.options = value
        end
      end
      
      if attributes[:'tableName']
        self.table_name = attributes[:'tableName']
      end
      
      if attributes[:'partitionKeys']
        if (value = attributes[:'partitionKeys']).is_a?(Array)
          self.partition_keys = value
        end
      end
      
      if attributes[:'rawQuery']
        self.raw_query = attributes[:'rawQuery']
      end
      
    end

  end
end
