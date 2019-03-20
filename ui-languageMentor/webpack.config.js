const webpack = require('webpack');
const path = require('path');

module.exports = {
	module: {
		rules: [
			{
				test: /\.ts$/,
				use: 'ts-loader'
			},
			{
				test: /\.(less|css)$/,

				use: [
					{
						loader: 'css-loader',

						options: {
							sourceMap: true
						}
					},
					{
						loader: 'less-loader',

						options: {
							sourceMap: true
						}
					}
				]
			}
		]
	},

	output: {
		filename: 'bundle.js',
		path: path.resolve(__dirname, 'dist')
	},

	mode: 'development',
	entry: './src/app-component.ts'
};
