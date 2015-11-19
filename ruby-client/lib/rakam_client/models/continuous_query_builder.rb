module RakamClient
  # 
  class ContinuousQueryBuilder < BaseObject
    attr_accessor :name, :query, :collections, :options, :table_name, :partition_keys
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'name' => :'name',
        
        # 
        :'query' => :'query',
        
        # 
        :'collections' => :'collections',
        
        # 
        :'options' => :'options',
        
        # 
        :'table_name' => :'tableName',
        
        # 
        :'partition_keys' => :'partitionKeys'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'name' => :'String',
        :'query' => :'String',
        :'collections' => :'Array<String>',
        :'options' => :'Hash<String, Object>',
        :'table_name' => :'String',
        :'partition_keys' => :'Array<String>'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'name']
        self.name = attributes[:'name']
      end
      
      if attributes[:'query']
        self.query = attributes[:'query']
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
      
    end

  end
end
