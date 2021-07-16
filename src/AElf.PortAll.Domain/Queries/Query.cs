using System.Collections.Generic;
using Volo.Abp.Domain.Entities;

namespace AElf.PortAll.Queries
{
    public class Query : Entity
    {
        /// <summary>
        /// Id of the Query tx.
        /// </summary>
        public string QueryTransactionId { get; set; }

        public Dictionary<string, string> CommitTransactionIdMap { get; set; }
        public Dictionary<string, string> RevealTransactionIdMap { get; set; }

        public string QueryId { get; set; }
        public string DesignatedNodeList { get; set; }
        public string ExpirationTimestamp { get; set; }
        public string FinalResult { get; set; }
        public decimal Payment { get; set; }
        public string CallbackContractAddress { get; set; }
        public string CallbackMethodName { get; set; }
        public int AggregateThreshold { get; set; }
        public string QuerySender { get; set; }
        public bool IsCommitStageFinished { get; set; }
        public int CommitmentsCount { get; set; }
        public bool IsCancelled { get; set; }
        public string QueryTitle { get; set; }
        public string QueryOptions { get; set; }
        public string Token { get; set; }

        /// <summary>
        /// Oracle Node Address -> Answer
        /// </summary>
        public Dictionary<string, string> DataRecords { get; set; }

        public int AggregateOption { get; set; }
        public string TaskId { get; set; }
        public bool IsPaidToOracleContract { get; set; }

        public QueryType QueryType { get; set; }

        public override object[] GetKeys()
        {
            return new object[] { QueryId };
        }
    }
/*
message QueryRecord {
    AddressList designated_node_list = 1;
    aelf.Address aggregator_contract_address = 2;
    google.protobuf.Timestamp expiration_timestamp = 3;
    bool is_sufficient_commitments_collected = 4;
    bool is_sufficient_data_collected = 5;
    string final_result = 6;
    int64 payment = 7;
    CallbackInfo callback_info = 8;
    aelf.Hash query_id = 9;
    int32 aggregate_threshold = 10;
    aelf.Address query_sender = 11;
    bool is_commit_stage_finished = 12;
    int32 commitments_count = 13;
    bool is_cancelled = 14;
    QueryInfo query_info = 15;
    string token = 16;
    DataRecords data_records = 17;
    int32 aggregate_option = 18;
    aelf.Hash task_id = 19;
    bool is_paid_to_oracle_contract = 20;
}
 */
}