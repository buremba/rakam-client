module RakamClient
  # 
  class RetentionQuery < BaseObject
    attr_accessor :project, :connector_field, :first_action, :returning_action, :dimension, :date_unit, :start_date, :end_date
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'project' => :'project',
        
        # 
        :'connector_field' => :'connector_field',
        
        # 
        :'first_action' => :'first_action',
        
        # 
        :'returning_action' => :'returning_action',
        
        # 
        :'dimension' => :'dimension',
        
        # 
        :'date_unit' => :'date_unit',
        
        # 
        :'start_date' => :'startDate',
        
        # 
        :'end_date' => :'endDate'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'project' => :'String',
        :'connector_field' => :'String',
        :'first_action' => :'RetentionAction',
        :'returning_action' => :'RetentionAction',
        :'dimension' => :'String',
        :'date_unit' => :'String',
        :'start_date' => :'Date',
        :'end_date' => :'Date'
        
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
      
      if attributes[:'first_action']
        self.first_action = attributes[:'first_action']
      end
      
      if attributes[:'returning_action']
        self.returning_action = attributes[:'returning_action']
      end
      
      if attributes[:'dimension']
        self.dimension = attributes[:'dimension']
      end
      
      if attributes[:'date_unit']
        self.date_unit = attributes[:'date_unit']
      end
      
      if attributes[:'startDate']
        self.start_date = attributes[:'startDate']
      end
      
      if attributes[:'endDate']
        self.end_date = attributes[:'endDate']
      end
      
    end

    def date_unit=(date_unit)
      allowed_values = ["DAY", "WEEK", "MONTH"]
      if date_unit && !allowed_values.include?(date_unit)
        fail "invalid value for 'date_unit', must be one of #{allowed_values}"
      end
      @date_unit = date_unit
    end

  end
end
