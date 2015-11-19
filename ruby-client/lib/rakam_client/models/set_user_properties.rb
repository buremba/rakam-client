module RakamClient
  # 
  class SetUserProperties < BaseObject
    attr_accessor :project, :user, :properties
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'project' => :'project',
        
        # 
        :'user' => :'user',
        
        # 
        :'properties' => :'properties'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'project' => :'String',
        :'user' => :'String',
        :'properties' => :'Hash<String, Object>'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'project']
        self.project = attributes[:'project']
      end
      
      if attributes[:'user']
        self.user = attributes[:'user']
      end
      
      if attributes[:'properties']
        if (value = attributes[:'properties']).is_a?(Array)
          self.properties = value
        end
      end
      
    end

  end
end
