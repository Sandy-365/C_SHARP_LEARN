namespace UltraEnterpriseSDLC
{
    enum RiskLevel
    {
        Low, Medium, High, Critical
    }
    enum SDLCStage
    {
        Backlog, Requirement, Design, Development, CodeReview, Testing, UAT, Deployment, Maintenance,
    }

    sealed class Requirement
    {
        public int Id { get; }
        public string Title { get; }
        public RiskLevel Risk { get; }

        public Requirement(int id, string title, RiskLevel risk)
        {
            Id = id;
            Title = title;
            Risk = risk;
        }

        sealed class WorkItem
        {
            public int Id { get; }
            public string Name { get; }
            public SDLCStage Stage { get; }
            public HashSet<int> DependencyIds { get; }

            public WorkItem(int id, string name, SDLCStage stage)
            {
                Id = id;
                Name = name;
                Stage = stage;
                DependencyIds = new HashSet<int>();
            }
        }

        sealed class BuildSnapshot
        {
            public string Version { get; }
            public DateTime Timestamp { get; }

            public BuildSnapshot(string version)
            {
                Version = version;
                Timestamp = DateTime.Now;
            }
        }

        sealed class AuditLog
        {
            public DateTime Time { get; }
            public string Action { get; }

            public AuditLog(string action)
            {
                Time = DateTime.Now;
                Action = action;
            }
        }

        sealed class QualityMetric
        {
            public string Name { get; }
            public double Score { get; }

            public QualityMetric(string name, double score)
            {
                Name = name;
                Score = score;
            }
        }

        class EnterpriseSDLCEngine
        {
            private List<Requirement> _requirements;
            private Dictionary<int, Requirement.WorkItem> _workItemRegistry;
            private SortedDictionary<SDLCStage, List<Requirement.WorkItem>> _stageBoard;
            private Queue<Requirement.WorkItem> _executionQueue;
            private Stack<Requirement.BuildSnapshot> _rollbackStack;
            private HashSet<string> _uniqueTestSuites;
            private LinkedList<Requirement.AuditLog> _auditLedger;
            private SortedList<double, Requirement.QualityMetric> _releaseScoreboard;
            private int _requirementCounter;
            private int _workItemCounter;

            public EnterpriseSDLCEngine()
            {
                _requirements = new List<Requirement>();
                _workItemRegistry = new Dictionary<int, Requirement.WorkItem>();
                _stageBoard = new SortedDictionary<SDLCStage, List<Requirement.WorkItem>>();
                _executionQueue = new Queue<Requirement.WorkItem>();
                _rollbackStack = new Stack<Requirement.BuildSnapshot>();
                _uniqueTestSuites = new HashSet<string>();
                _auditLedger = new LinkedList<Requirement.AuditLog>();
                _releaseScoreboard = new SortedList<double, Requirement.QualityMetric>();
                _requirementCounter = 0;
                _workItemCounter = 0;

                foreach (SDLCStage stage in Enum.GetValues(typeof(SDLCStage)))
                    _stageBoard[stage] = new List<Requirement.WorkItem>();
            }


            public void AddRequirement(string title, RiskLevel risk)
            {
                var requirement = new Requirement(_requirementCounter, title, risk);
                _requirementCounter++;

                _requirements.Add(requirement);

                var log = new Requirement.AuditLog(
                    $"Requirement added: Id={requirement.Id}, Title='{title}', Risk={risk}"
                );
                _auditLedger.AddLast(log);
            }

            // Method: CreateWorkItem
            public Requirement.WorkItem CreateWorkItem(string name, SDLCStage stage)
            {
                var workItem = new Requirement.WorkItem(_workItemCounter, name, stage);
                _workItemCounter++;

                _workItemRegistry.Add(workItem.Id, workItem);

                _stageBoard[stage].Add(workItem);

                var log = new Requirement.AuditLog(
                    $"WorkItem created: Name='{name}', Stage={stage}"
                );
                _auditLedger.AddLast(log);

                return workItem;
            }
        }

    }
}