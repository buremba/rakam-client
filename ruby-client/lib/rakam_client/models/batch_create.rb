module RakamClient
  # 
  class BatchCreate < BaseObject
    attr_accessor :project, :users
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'project' => :'project',
        
        # 
        :'users' => :'users'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'project' => :'String',
        :'users' => :'Array<User>'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'project']
        self.project = attributes[:'project']
      end
      
      if attributes[:'users']
        if (value = attributes[:'users']).is_a?(Array)
          self.users = value
        end
      end
      
    end

  end
end
