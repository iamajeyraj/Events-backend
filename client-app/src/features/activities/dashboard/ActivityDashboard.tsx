import { Col, Row } from "react-bootstrap";
import { Activity } from "../../../app/models/activity";
import ActivityList from "./ActivityList";
import ActivityDetails from "../details/ActivityDetails";
import ActivityForm from "../form/ActivityForm";
// import ActivityDetails from "../details/ActivityDetails";

interface Props {
    activities: Activity[];
    selectedActivity: Activity | undefined;
    editMode: boolean;
    selectActivity: (id: string) => void;
    cancelSelectedActivity: () => void;
    openForm: (id: string) => void;
    closeForm: () => void;
    upsertActivity: (activity: Activity) => void;
    deleteActivity: (id: string) => void;
}

export default function ActivityDashboard({ activities, selectedActivity, editMode,
    selectActivity, cancelSelectedActivity,
    openForm, closeForm, upsertActivity,deleteActivity }: Props) {
    return (
        <Row>
            <Col md={6} className="mx-5">
                <ActivityList activities={activities}
                    selectActivity={selectActivity}
                    deleteActivity={deleteActivity}
                />
            </Col>
            <Col md={4} className="mt-4">
                <div>
                    {
                        !editMode && selectedActivity && <ActivityDetails
                            activity={selectedActivity}
                            cancelSelectedActivity={cancelSelectedActivity}
                            openForm={openForm}
                        />
                    }
                </div>
                <div className="pt-4">
                    {editMode && <ActivityForm upsertActivity={upsertActivity} activity={selectedActivity} closeForm={closeForm} />}
                </div>
            </Col>
        </Row>
    )
}
