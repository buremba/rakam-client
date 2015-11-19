module RakamClient
  # 
  class SchemaField < BaseObject
    attr_accessor :name, :type, :nullable, :unique, :descriptive_name, :description, :category
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'name' => :'name',
        
        # 
        :'type' => :'type',
        
        # 
        :'nullable' => :'nullable',
        
        # 
        :'unique' => :'unique',
        
        # 
        :'descriptive_name' => :'descriptiveName',
        
        # 
        :'description' => :'description',
        
        # 
        :'category' => :'category'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'name' => :'String',
        :'type' => :'String',
        :'nullable' => :'BOOLEAN',
        :'unique' => :'BOOLEAN',
        :'descriptive_name' => :'String',
        :'description' => :'String',
        :'category' => :'String'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'name']
        self.name = attributes[:'name']
      end
      
      if attributes[:'type']
        self.type = attributes[:'type']
      end
      
      if attributes[:'nullable']
        self.nullable = attributes[:'nullable']
      end
      
      if attributes[:'unique']
        self.unique = attributes[:'unique']
      end
      
      if attributes[:'descriptiveName']
        self.descriptive_name = attributes[:'descriptiveName']
      end
      
      if attributes[:'description']
        self.description = attributes[:'description']
      end
      
      if attributes[:'category']
        self.category = attributes[:'category']
      end
      
    end

    def type=(type)
      allowed_values = ["STRING", "LONG", "DOUBLE", "BOOLEAN", "DATE", "TIME", "TIMESTAMP", "ARRAY_STRING", "ARRAY_LONG", "ARRAY_DOUBLE", "ARRAY_BOOLEAN", "ARRAY_DATE", "ARRAY_TIME", "ARRAY_TIMESTAMP"]
      if type && !allowed_values.include?(type)
        fail "invalid value for 'type', must be one of #{allowed_values}"
      end
      @type = type
    end

  end
end
