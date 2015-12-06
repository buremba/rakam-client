module RakamClient
  # 
  class Variant < BaseObject
    attr_accessor :name, :weight, :data
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'name' => :'name',
        
        # 
        :'weight' => :'weight',
        
        # 
        :'data' => :'data'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'name' => :'String',
        :'weight' => :'Integer',
        :'data' => :'Object'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'name']
        self.name = attributes[:'name']
      end
      
      if attributes[:'weight']
        self.weight = attributes[:'weight']
      end
      
      if attributes[:'data']
        self.data = attributes[:'data']
      end
      
    end

  end
end
