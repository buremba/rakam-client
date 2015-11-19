module RakamClient
  # 
  class EventList < BaseObject
    attr_accessor :api, :project, :events
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'api' => :'api',
        
        # 
        :'project' => :'project',
        
        # 
        :'events' => :'events'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'api' => :'EventContext',
        :'project' => :'String',
        :'events' => :'Array<Event>'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'api']
        self.api = attributes[:'api']
      end
      
      if attributes[:'project']
        self.project = attributes[:'project']
      end
      
      if attributes[:'events']
        if (value = attributes[:'events']).is_a?(Array)
          self.events = value
        end
      end
      
    end

  end
end
