module RakamClient
  # 
  class MetadataResponse < BaseObject
    attr_accessor :columns, :identifier_column
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'columns' => :'columns',
        
        # 
        :'identifier_column' => :'identifierColumn'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'columns' => :'Array<SchemaField>',
        :'identifier_column' => :'String'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'columns']
        if (value = attributes[:'columns']).is_a?(Array)
          self.columns = value
        end
      end
      
      if attributes[:'identifierColumn']
        self.identifier_column = attributes[:'identifierColumn']
      end
      
    end

  end
end
