import { PolymerElement, html } from '@polymer/polymer';

export class ExaminationComponent extends PolymerElement {
    static get template() {
        return html`<div>Examination</div>`;
    }
}

customElements.define('examination-component', ExaminationComponent);