module RakamClient
  # 
  class QueryError < BaseObject
    attr_accessor :message, :sql_state, :error_code, :query
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'message' => :'message',
        
        # 
        :'sql_state' => :'sqlState',
        
        # 
        :'error_code' => :'errorCode',
        
        # 
        :'query' => :'query'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'message' => :'String',
        :'sql_state' => :'String',
        :'error_code' => :'Integer',
        :'query' => :'String'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'message']
        self.message = attributes[:'message']
      end
      
      if attributes[:'sqlState']
        self.sql_state = attributes[:'sqlState']
      end
      
      if attributes[:'errorCode']
        self.error_code = attributes[:'errorCode']
      end
      
      if attributes[:'query']
        self.query = attributes[:'query']
      end
      
    end

  end
end
