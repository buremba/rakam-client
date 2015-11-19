module RakamClient
  # 
  class SearchUsers < BaseObject
    attr_accessor :project, :filter, :event_filters, :sorting, :offset, :limit
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
        :'sorting' => :'sorting',
        
        # 
        :'offset' => :'offset',
        
        # 
        :'limit' => :'limit'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'project' => :'String',
        :'filter' => :'String',
        :'event_filters' => :'Array<EventFilter>',
        :'sorting' => :'Sorting',
        :'offset' => :'Integer',
        :'limit' => :'Integer'
        
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
      
      if attributes[:'sorting']
        self.sorting = attributes[:'sorting']
      end
      
      if attributes[:'offset']
        self.offset = attributes[:'offset']
      end
      
      if attributes[:'limit']
        self.limit = attributes[:'limit']
      end
      
    end

  end
end
