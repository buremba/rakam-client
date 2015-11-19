module RakamClient
  # 
  class ReportBuilder < BaseObject
    attr_accessor :slug, :name, :query, :options
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'slug' => :'slug',
        
        # 
        :'name' => :'name',
        
        # 
        :'query' => :'query',
        
        # 
        :'options' => :'options'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'slug' => :'String',
        :'name' => :'String',
        :'query' => :'String',
        :'options' => :'Hash<String, Object>'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'slug']
        self.slug = attributes[:'slug']
      end
      
      if attributes[:'name']
        self.name = attributes[:'name']
      end
      
      if attributes[:'query']
        self.query = attributes[:'query']
      end
      
      if attributes[:'options']
        if (value = attributes[:'options']).is_a?(Array)
          self.options = value
        end
      end
      
    end

  end
end
