module RakamClient
  # 
  class MailAction < BaseObject
    attr_accessor :message, :variables, :from_user
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'message' => :'message',
        
        # 
        :'variables' => :'variables',
        
        # 
        :'from_user' => :'fromUser'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'message' => :'String',
        :'variables' => :'Hash<String, String>',
        :'from_user' => :'String'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'message']
        self.message = attributes[:'message']
      end
      
      if attributes[:'variables']
        if (value = attributes[:'variables']).is_a?(Array)
          self.variables = value
        end
      end
      
      if attributes[:'fromUser']
        self.from_user = attributes[:'fromUser']
      end
      
    end

  end
end
