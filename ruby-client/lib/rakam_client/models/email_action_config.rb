module RakamClient
  # 
  class EmailActionConfig < BaseObject
    attr_accessor :title, :content, :column_name, :default_values, :rich_text
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'title' => :'title',
        
        # 
        :'content' => :'content',
        
        # 
        :'column_name' => :'columnName',
        
        # 
        :'default_values' => :'defaultValues',
        
        # 
        :'rich_text' => :'richText'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'title' => :'String',
        :'content' => :'String',
        :'column_name' => :'String',
        :'default_values' => :'Hash<String, String>',
        :'rich_text' => :'BOOLEAN'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'title']
        self.title = attributes[:'title']
      end
      
      if attributes[:'content']
        self.content = attributes[:'content']
      end
      
      if attributes[:'columnName']
        self.column_name = attributes[:'columnName']
      end
      
      if attributes[:'defaultValues']
        if (value = attributes[:'defaultValues']).is_a?(Array)
          self.default_values = value
        end
      end
      
      if attributes[:'richText']
        self.rich_text = attributes[:'richText']
      end
      
    end

  end
end
