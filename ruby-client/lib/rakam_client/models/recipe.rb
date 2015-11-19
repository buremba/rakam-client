module RakamClient
  # 
  class Recipe < BaseObject
    attr_accessor :strategy, :project, :collections, :reports, :materialized_views, :continuous_queries, :continuous_query_builders, :materialized_view_builders
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'strategy' => :'strategy',
        
        # 
        :'project' => :'project',
        
        # 
        :'collections' => :'collections',
        
        # 
        :'reports' => :'reports',
        
        # 
        :'materialized_views' => :'materializedViews',
        
        # 
        :'continuous_queries' => :'continuousQueries',
        
        # 
        :'continuous_query_builders' => :'continuousQueryBuilders',
        
        # 
        :'materialized_view_builders' => :'materializedViewBuilders'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'strategy' => :'String',
        :'project' => :'String',
        :'collections' => :'Hash<String, Collection>',
        :'reports' => :'Array<ReportBuilder>',
        :'materialized_views' => :'Array<MaterializedViewBuilder>',
        :'continuous_queries' => :'Array<ContinuousQueryBuilder>',
        :'continuous_query_builders' => :'Array<ContinuousQueryBuilder>',
        :'materialized_view_builders' => :'Array<MaterializedViewBuilder>'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'strategy']
        self.strategy = attributes[:'strategy']
      end
      
      if attributes[:'project']
        self.project = attributes[:'project']
      end
      
      if attributes[:'collections']
        if (value = attributes[:'collections']).is_a?(Array)
          self.collections = value
        end
      end
      
      if attributes[:'reports']
        if (value = attributes[:'reports']).is_a?(Array)
          self.reports = value
        end
      end
      
      if attributes[:'materializedViews']
        if (value = attributes[:'materializedViews']).is_a?(Array)
          self.materialized_views = value
        end
      end
      
      if attributes[:'continuousQueries']
        if (value = attributes[:'continuousQueries']).is_a?(Array)
          self.continuous_queries = value
        end
      end
      
      if attributes[:'continuousQueryBuilders']
        if (value = attributes[:'continuousQueryBuilders']).is_a?(Array)
          self.continuous_query_builders = value
        end
      end
      
      if attributes[:'materializedViewBuilders']
        if (value = attributes[:'materializedViewBuilders']).is_a?(Array)
          self.materialized_view_builders = value
        end
      end
      
    end

    def strategy=(strategy)
      allowed_values = ["DEFAULT", "SPECIFIC"]
      if strategy && !allowed_values.include?(strategy)
        fail "invalid value for 'strategy', must be one of #{allowed_values}"
      end
      @strategy = strategy
    end

  end
end
