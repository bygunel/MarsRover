namespace MarsRover.BL
{
    public class OperationControls
    {
        OperationInformation _OperationInformation;
        private bool InTheMap(int CoordinateX, int CoordinateY)
        {
            if (CoordinateX > _OperationInformation.UpperRightCoordinateX || CoordinateY > _OperationInformation.UpperRightCoordinateY)
                return false;

            return true;
        }
        private RobotStatus NextMove(char nextMove, RobotStatus currentStatus)
        {
            // Left
            if (nextMove == 'L')
            {
                switch (currentStatus.CurrentDirection)
                {
                    case 'E':
                        currentStatus.CurrentDirection = 'N';
                        break;
                    case 'N':
                        currentStatus.CurrentDirection = 'W';
                        break;
                    case 'W':
                        currentStatus.CurrentDirection = 'S';
                        break;
                    case 'S':
                        currentStatus.CurrentDirection = 'E';
                        break;
                }
                return currentStatus;
            }
            // Right
            if (nextMove == 'R')
            {
                switch (currentStatus.CurrentDirection)
                {
                    case 'E':
                        currentStatus.CurrentDirection = 'S';
                        break;
                    case 'S':
                        currentStatus.CurrentDirection = 'W';
                        break;
                    case 'W':
                        currentStatus.CurrentDirection = 'N';
                        break;
                    case 'N':
                        currentStatus.CurrentDirection = 'E';
                        break;
                }
                return currentStatus;
            }
            // Move
            switch (currentStatus.CurrentDirection)
            {
                case 'E':
                    currentStatus = (InTheMap(currentStatus.CurrentLocationX + 1, currentStatus.CurrentLocationY)) ? new RobotStatus { CurrentLocationX = currentStatus.CurrentLocationX + 1, CurrentLocationY = currentStatus.CurrentLocationY, CurrentDirection = currentStatus.CurrentDirection } : null;
                        break;
                case 'W':
                    currentStatus = (InTheMap(currentStatus.CurrentLocationX - 1, currentStatus.CurrentLocationY)) ? new RobotStatus { CurrentLocationX = currentStatus.CurrentLocationX - 1, CurrentLocationY = currentStatus.CurrentLocationY, CurrentDirection = currentStatus.CurrentDirection } : null;
                    break;
                case 'N':
                    currentStatus = (InTheMap(currentStatus.CurrentLocationX, currentStatus.CurrentLocationY + 1)) ? new RobotStatus { CurrentLocationX = currentStatus.CurrentLocationX, CurrentLocationY = currentStatus.CurrentLocationY + 1, CurrentDirection = currentStatus.CurrentDirection } : null;
                    break;
                case 'S':
                    currentStatus = (InTheMap(currentStatus.CurrentLocationX, currentStatus.CurrentLocationY - 1)) ? new RobotStatus { CurrentLocationX = currentStatus.CurrentLocationX, CurrentLocationY = currentStatus.CurrentLocationY - 1, CurrentDirection = currentStatus.CurrentDirection } : null;
                    break;
            }

            return currentStatus;

        }
        public string MainControls(OperationInformation operationInformation)
        { 
            _OperationInformation = operationInformation;
            if (!InTheMap(_OperationInformation.FirstLocationX, _OperationInformation.FirstLocationY))
                return "First location is NOT valid !!!";

            RobotStatus robotStatus = new RobotStatus
            {
                CurrentLocationX = _OperationInformation.FirstLocationX,
                CurrentLocationY = _OperationInformation.FirstLocationY,
                CurrentDirection = _OperationInformation.FirstDirection
            };
            int step = 0;
            foreach (char operation in _OperationInformation.MovementDirectives)
            {
                step++;
                robotStatus = NextMove(operation, robotStatus);
                if (robotStatus == null)
                    return string.Format("{0}. step operation invalid !!!", step);
            }
            
            
            return string.Format("{0} {1} {2}", robotStatus.CurrentLocationX, robotStatus.CurrentLocationY, robotStatus.CurrentDirection);
        }

    }
}
