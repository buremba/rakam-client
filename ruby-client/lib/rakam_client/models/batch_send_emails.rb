module RakamClient
  # 
  class BatchSendEmails < BaseObject
    attr_accessor :project, :filter, :event_filters, :config
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'project' => :'project',
        
        # 
        :'filter' => :'filter',
        
        # 
        :'event_filters' => :'event_filters',
        
        # 
        :'config' => :'config'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'project' => :'String',
        :'filter' => :'String',
        :'event_filters' => :'Array<EventFilter>',
        :'config' => :'EmailActionConfig'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'project']
        self.project = attributes[:'project']
      end
      
      if attributes[:'filter']
        self.filter = attributes[:'filter']
      end
      
      if attributes[:'event_filters']
        if (value = attributes[:'event_filters']).is_a?(Array)
          self.event_filters = value
        end
      end
      
      if attributes[:'config']
        self.config = attributes[:'config']
      end
      
    end

  end
end
