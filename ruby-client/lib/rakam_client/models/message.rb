module RakamClient
  # 
  class Message < BaseObject
    attr_accessor :id, :content, :from_user, :to_user, :parent_id, :seen, :time, :project
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'id' => :'id',
        
        # 
        :'content' => :'content',
        
        # 
        :'from_user' => :'from_user',
        
        # 
        :'to_user' => :'to_user',
        
        # 
        :'parent_id' => :'parentId',
        
        # 
        :'seen' => :'seen',
        
        # 
        :'time' => :'time',
        
        # 
        :'project' => :'project'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'id' => :'Integer',
        :'content' => :'String',
        :'from_user' => :'Object',
        :'to_user' => :'Object',
        :'parent_id' => :'Integer',
        :'seen' => :'BOOLEAN',
        :'time' => :'Integer',
        :'project' => :'String'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'id']
        self.id = attributes[:'id']
      end
      
      if attributes[:'content']
        self.content = attributes[:'content']
      end
      
      if attributes[:'from_user']
        self.from_user = attributes[:'from_user']
      end
      
      if attributes[:'to_user']
        self.to_user = attributes[:'to_user']
      end
      
      if attributes[:'parentId']
        self.parent_id = attributes[:'parentId']
      end
      
      if attributes[:'seen']
        self.seen = attributes[:'seen']
      end
      
      if attributes[:'time']
        self.time = attributes[:'time']
      end
      
      if attributes[:'project']
        self.project = attributes[:'project']
      end
      
    end

  end
end
