module RakamClient
  # 
  class Execute < BaseObject
    attr_accessor :project, :measure, :grouping, :segment, :filter_expression, :start_date, :end_date, :collections
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'project' => :'project',
        
        # 
        :'measure' => :'measure',
        
        # 
        :'grouping' => :'grouping',
        
        # 
        :'segment' => :'segment',
        
        # 
        :'filter_expression' => :'filterExpression',
        
        # 
        :'start_date' => :'startDate',
        
        # 
        :'end_date' => :'endDate',
        
        # 
        :'collections' => :'collections'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'project' => :'String',
        :'measure' => :'Measure',
        :'grouping' => :'Reference',
        :'segment' => :'Reference',
        :'filter_expression' => :'String',
        :'start_date' => :'Date',
        :'end_date' => :'Date',
        :'collections' => :'Array<String>'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'project']
        self.project = attributes[:'project']
      end
      
      if attributes[:'measure']
        self.measure = attributes[:'measure']
      end
      
      if attributes[:'grouping']
        self.grouping = attributes[:'grouping']
      end
      
      if attributes[:'segment']
        self.segment = attributes[:'segment']
      end
      
      if attributes[:'filterExpression']
        self.filter_expression = attributes[:'filterExpression']
      end
      
      if attributes[:'startDate']
        self.start_date = attributes[:'startDate']
      end
      
      if attributes[:'endDate']
        self.end_date = attributes[:'endDate']
      end
      
      if attributes[:'collections']
        if (value = attributes[:'collections']).is_a?(Array)
          self.collections = value
        end
      end
      
    end

  end
end
