import * as React from 'react';
import { connect } from 'react-redux';
import { RouteComponentProps } from 'react-router';
import { Link } from 'react-router-dom';
import { ApplicationState } from '../store';
import * as WeatherForecastsStore from '../store/WeatherForecasts';

interface FetchEmployeeDataState {
    empList: EmployeeData[];
    loading: boolean;
}  


export class FetchEmployee extends React.Component<RouteComponentProps<{}>, FetchEmployeeDataState> {
    public test() {
        this.state = { empList: [], loading: true };
        fetch('api/Task/Index')
            .then(response => response.json() as Promise<EmployeeData[]>)
            .then(data => {
                this.setState({ empList: data, loading: false });
            });
        this.handleDelete = this.handleDelete.bind(this);
        this.handleEdit = this.handleEdit.bind(this);
    }
    public render() {
        this.test();
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : this.renderEmployeeTable(this.state.empList);
        return <div>
            <h1>Employee Data</h1>
            <p>This component demonstrates fetching Employee data from the server.</p>
            <p>
                <Link to="/addemployee">Create New</Link>
            </p>
            {contents}
        </div>;
    }
    // Handle Delete request for an employee  
    private handleDelete(id: number) {
        if (!confirm("Do you want to delete employee with Id: " + id))
            return;
        else {
            fetch('api/Employee/Delete/' + id, {
                method: 'delete'
            }).then(data => {
                this.setState(
                    {
                        empList: this.state.empList.filter((rec) => {
                            return (rec.Id != id);
                        })
                    });
            });
        }
    }
    private handleEdit(id: number) {
        this.props.history.push("/employee/edit/" + id);
    }
    // Returns the HTML table to the render() method.  
    private renderEmployeeTable(empList: EmployeeData[]) {
        return <table className='table'>
            <thead>
                <tr>
                    <th></th>
                    <th>Id</th>
                    <th>Name</th>
                    <th>Text</th>
                </tr>
            </thead>
            <tbody>
                {empList.map(emp =>
                    <tr key={emp.Id}>
                        <td></td>
                        <td>{emp.Id}</td>
                        <td>{emp.Name}</td>
                        <td>{emp.Text}</td>
                        <td>
                            <a className="action" onClick={(id) => this.handleEdit(emp.Id)}>Edit</a>  |
                            <a className="action" onClick={(id) => this.handleDelete(emp.Id)}>Delete</a>
                        </td>
                    </tr>
                )}
            </tbody>
        </table>;
    }
}
export class EmployeeData {
    Id: number = 0;
    Name: string = "";
    Text: string = "";
}
