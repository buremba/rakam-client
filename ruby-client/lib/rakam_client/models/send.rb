module RakamClient
  # 
  class Send < BaseObject
    attr_accessor :project, :user, :config
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'project' => :'project',
        
        # 
        :'user' => :'user',
        
        # 
        :'config' => :'config'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'project' => :'String',
        :'user' => :'String',
        :'config' => :'EmailActionConfig'
        
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
      
      if attributes[:'config']
        self.config = attributes[:'config']
      end
      
    end

  end
end
