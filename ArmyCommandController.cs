using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NickDIDemo.Services.Archer;
using NickDIDemo.Services.Cavalry;
using NickDIDemo.Services.Infantry;

namespace NickDIDemo
{
    public class ArmyCommandController
    {
        private IArcher _archerService;
        private ICavalry _cavalryService;
        private IInfantry _infantryService;

        public ArmyCommandController(IArcher archerService, ICavalry cavalryService, IInfantry infantryService)
        {
            this._archerService = archerService;
            this._cavalryService = cavalryService;
            this._infantryService = infantryService;
        }

        public void SendOrder(ArmyType type)
        {
            switch (type)
            {
                case ArmyType.Infantry:
                    _infantryService.Guard();
                    break;
                case ArmyType.Cavalry:
                    _cavalryService.Charge();
                    break;
                case ArmyType.Archer:
                    _archerService.MultiShot();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }

    }

    public enum ArmyType
    {
        Infantry = 0,
        Cavalry = 1,
        Archer = 2
    }
}
