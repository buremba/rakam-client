module RakamClient
  # 
  class QueryResult < BaseObject
    attr_accessor :metadata, :result, :error, :properties, :failed
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'metadata' => :'metadata',
        
        # 
        :'result' => :'result',
        
        # 
        :'error' => :'error',
        
        # 
        :'properties' => :'properties',
        
        # 
        :'failed' => :'failed'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'metadata' => :'Array<SchemaField>',
        :'result' => :'Array<Array<Object>>',
        :'error' => :'QueryError',
        :'properties' => :'Hash<String, Object>',
        :'failed' => :'BOOLEAN'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'metadata']
        if (value = attributes[:'metadata']).is_a?(Array)
          self.metadata = value
        end
      end
      
      if attributes[:'result']
        if (value = attributes[:'result']).is_a?(Array)
          self.result = value
        end
      end
      
      if attributes[:'error']
        self.error = attributes[:'error']
      end
      
      if attributes[:'properties']
        if (value = attributes[:'properties']).is_a?(Array)
          self.properties = value
        end
      end
      
      if attributes[:'failed']
        self.failed = attributes[:'failed']
      end
      
    end

  end
end
