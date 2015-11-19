module RakamClient
  # 
  class MaterializedViewSchema < BaseObject
    attr_accessor :name, :fields
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'name' => :'name',
        
        # 
        :'fields' => :'fields'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'name' => :'String',
        :'fields' => :'Array<SchemaField>'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'name']
        self.name = attributes[:'name']
      end
      
      if attributes[:'fields']
        if (value = attributes[:'fields']).is_a?(Array)
          self.fields = value
        end
      end
      
    end

  end
end
