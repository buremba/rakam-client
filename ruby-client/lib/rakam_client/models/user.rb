module RakamClient
  # 
  class User < BaseObject
    attr_accessor :project, :id, :properties
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'project' => :'project',
        
        # 
        :'id' => :'id',
        
        # 
        :'properties' => :'properties'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'project' => :'String',
        :'id' => :'String',
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
      
      if attributes[:'id']
        self.id = attributes[:'id']
      end
      
      if attributes[:'properties']
        if (value = attributes[:'properties']).is_a?(Array)
          self.properties = value
        end
      end
      
    end

  end
end
