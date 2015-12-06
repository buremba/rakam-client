module RakamClient
  # 
  class SerializableAction < BaseObject
    attr_accessor :type, :value
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'type' => :'type',
        
        # 
        :'value' => :'value'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'type' => :'String',
        :'value' => :'Object'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'type']
        self.type = attributes[:'type']
      end
      
      if attributes[:'value']
        self.value = attributes[:'value']
      end
      
    end

    def type=(type)
      allowed_values = ["client", "user_action", "event"]
      if type && !allowed_values.include?(type)
        fail "invalid value for 'type', must be one of #{allowed_values}"
      end
      @type = type
    end

  end
end
