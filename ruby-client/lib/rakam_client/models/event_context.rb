module RakamClient
  # 
  class EventContext < BaseObject
    attr_accessor :write_key, :api_version, :upload_time, :checksum
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'write_key' => :'writeKey',
        
        # 
        :'api_version' => :'apiVersion',
        
        # 
        :'upload_time' => :'uploadTime',
        
        # 
        :'checksum' => :'checksum'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'write_key' => :'String',
        :'api_version' => :'String',
        :'upload_time' => :'Integer',
        :'checksum' => :'String'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'writeKey']
        self.write_key = attributes[:'writeKey']
      end
      
      if attributes[:'apiVersion']
        self.api_version = attributes[:'apiVersion']
      end
      
      if attributes[:'uploadTime']
        self.upload_time = attributes[:'uploadTime']
      end
      
      if attributes[:'checksum']
        self.checksum = attributes[:'checksum']
      end
      
    end

  end
end
