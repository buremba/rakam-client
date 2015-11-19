module RakamClient
  # 
  class RealTimeReport < BaseObject
    attr_accessor :project, :name, :aggregation, :table_name, :collections, :filter, :measure, :dimensions
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'project' => :'project',
        
        # 
        :'name' => :'name',
        
        # 
        :'aggregation' => :'aggregation',
        
        # 
        :'table_name' => :'table_name',
        
        # 
        :'collections' => :'collections',
        
        # 
        :'filter' => :'filter',
        
        # 
        :'measure' => :'measure',
        
        # 
        :'dimensions' => :'dimensions'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'project' => :'String',
        :'name' => :'String',
        :'aggregation' => :'String',
        :'table_name' => :'String',
        :'collections' => :'Array<String>',
        :'filter' => :'String',
        :'measure' => :'String',
        :'dimensions' => :'Array<String>'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'project']
        self.project = attributes[:'project']
      end
      
      if attributes[:'name']
        self.name = attributes[:'name']
      end
      
      if attributes[:'aggregation']
        self.aggregation = attributes[:'aggregation']
      end
      
      if attributes[:'table_name']
        self.table_name = attributes[:'table_name']
      end
      
      if attributes[:'collections']
        if (value = attributes[:'collections']).is_a?(Array)
          self.collections = value
        end
      end
      
      if attributes[:'filter']
        self.filter = attributes[:'filter']
      end
      
      if attributes[:'measure']
        self.measure = attributes[:'measure']
      end
      
      if attributes[:'dimensions']
        if (value = attributes[:'dimensions']).is_a?(Array)
          self.dimensions = value
        end
      end
      
    end

    def aggregation=(aggregation)
      allowed_values = ["COUNT", "COUNT_UNIQUE", "SUM", "MINIMUM", "MAXIMUM", "APPROXIMATE_UNIQUE", "VARIANCE", "POPULATION_VARIANCE", "STANDARD_DEVIATION", "AVERAGE"]
      if aggregation && !allowed_values.include?(aggregation)
        fail "invalid value for 'aggregation', must be one of #{allowed_values}"
      end
      @aggregation = aggregation
    end

  end
end
