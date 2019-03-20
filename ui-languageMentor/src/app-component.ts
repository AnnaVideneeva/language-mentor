import { PolymerElement, html } from '@polymer/polymer';
import { ExaminationComponent } from './components/examination/examination-component';

export class AppComponent extends PolymerElement {
    static get template() {
        return html`
        <h2>Language Mentor</h2>
        <examination-component></examination-component>
        `;
    }
}

customElements.define('app-component', AppComponent);