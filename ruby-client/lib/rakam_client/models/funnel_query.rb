module RakamClient
  # 
  class FunnelQuery < BaseObject
    attr_accessor :project, :connector_field, :steps, :dimension, :start_date, :end_date, :enable_other_grouping
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'project' => :'project',
        
        # 
        :'connector_field' => :'connector_field',
        
        # 
        :'steps' => :'steps',
        
        # 
        :'dimension' => :'dimension',
        
        # 
        :'start_date' => :'startDate',
        
        # 
        :'end_date' => :'endDate',
        
        # 
        :'enable_other_grouping' => :'enableOtherGrouping'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'project' => :'String',
        :'connector_field' => :'String',
        :'steps' => :'Array<FunnelStep>',
        :'dimension' => :'String',
        :'start_date' => :'Date',
        :'end_date' => :'Date',
        :'enable_other_grouping' => :'BOOLEAN'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'project']
        self.project = attributes[:'project']
      end
      
      if attributes[:'connector_field']
        self.connector_field = attributes[:'connector_field']
      end
      
      if attributes[:'steps']
        if (value = attributes[:'steps']).is_a?(Array)
          self.steps = value
        end
      end
      
      if attributes[:'dimension']
        self.dimension = attributes[:'dimension']
      end
      
      if attributes[:'startDate']
        self.start_date = attributes[:'startDate']
      end
      
      if attributes[:'endDate']
        self.end_date = attributes[:'endDate']
      end
      
      if attributes[:'enableOtherGrouping']
        self.enable_other_grouping = attributes[:'enableOtherGrouping']
      end
      
    end

  end
end
