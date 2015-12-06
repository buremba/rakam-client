# Common files
require 'rakam_client/api_client'
require 'rakam_client/api_error'
require 'rakam_client/version'
require 'rakam_client/configuration'

# Models
require 'rakam_client/models/base_object'
require 'rakam_client/models/continuous_query_builder'
require 'rakam_client/models/user'
require 'rakam_client/models/execute'
require 'rakam_client/models/message'
require 'rakam_client/models/recipe'
require 'rakam_client/models/batch_create'
require 'rakam_client/models/batch_send_messages'
require 'rakam_client/models/json_response'
require 'rakam_client/models/send'
require 'rakam_client/models/query_result'
require 'rakam_client/models/goal'
require 'rakam_client/models/continuous_query'
require 'rakam_client/models/report_builder'
require 'rakam_client/models/measure'
require 'rakam_client/models/search_users'
require 'rakam_client/models/metadata_response'
require 'rakam_client/models/set_user_properties'
require 'rakam_client/models/query_error'
require 'rakam_client/models/event_filter_aggregation'
require 'rakam_client/models/funnel_query'
require 'rakam_client/models/threshold'
require 'rakam_client/models/materialized_view_builder'
require 'rakam_client/models/ab_testing_report'
require 'rakam_client/models/reference'
require 'rakam_client/models/collection_event'
require 'rakam_client/models/real_time_report'
require 'rakam_client/models/serializable_action'
require 'rakam_client/models/retention_action'
require 'rakam_client/models/email_action_config'
require 'rakam_client/models/event_filter'
require 'rakam_client/models/scenario_step'
require 'rakam_client/models/sorting'
require 'rakam_client/models/schema_field'
require 'rakam_client/models/automation_rule'
require 'rakam_client/models/variant'
require 'rakam_client/models/event_context'
require 'rakam_client/models/materialized_view_schema'
require 'rakam_client/models/event_list'
require 'rakam_client/models/batch_send_emails'
require 'rakam_client/models/mail_action'
require 'rakam_client/models/collection'
require 'rakam_client/models/event'
require 'rakam_client/models/materialized_view'
require 'rakam_client/models/retention_query'
require 'rakam_client/models/funnel_step'

# APIs
require 'rakam_client/api/funnel_api'
require 'rakam_client/api/automation_api'
require 'rakam_client/api/user_api'
require 'rakam_client/api/abtesting_api'
require 'rakam_client/api/recipe_api'
require 'rakam_client/api/materializedview_api'
require 'rakam_client/api/admin_api'
require 'rakam_client/api/retention_api'
require 'rakam_client/api/useraction_api'
require 'rakam_client/api/realtime_api'
require 'rakam_client/api/usermailbox_api'
require 'rakam_client/api/continuousquery_api'
require 'rakam_client/api/event_api'
require 'rakam_client/api/eventexplorer_api'

module RakamClient
  class << self
    # Configure sdk using block.
    # RakamClient.configure do |config|
    #   config.username = "xxx"
    #   config.password = "xxx"
    # end
    # If no block given, return the configuration singleton instance.
    def configure
      if block_given?
        yield Configuration.instance
      else
        Configuration.instance
      end
    end
  end
end
